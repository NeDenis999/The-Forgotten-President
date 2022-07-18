using System;
using System.Linq;
using Code.Extensions;
using Code.ViewListeners;
using Entitas;
using UnityEngine;
using static Code.Constants;
using Object = UnityEngine.Object;

namespace Code.Services
{
  public class UnityViewService : IViewService
  {
    private Transform _uiRoot;
    private readonly Transform _viewRoot = new GameObject(ViewRootName).transform;

    public UnityViewService() => CacheUIRoot();

    public void CreateView<T>(GameContext game, IEntity entity, string name) where T : Component, IViewController
    {
      CreateEmptyObject(with: name)
        .CreateController<T>(@in: game, bindTo: entity)
        .AddListeners(@from: entity)
        .RegisterListeners(with: entity);

      GameObject CreateEmptyObject(string with)
      {
        GameObject newObject = new GameObject(with);
        newObject.transform.SetParent(Root(with));

        return newObject;
      }
    }

    public void LoadView<T>(GameContext game, IEntity entity, string name) where T : Component, IViewController
    {
      LoadAndInstantiateObject(with: name)
        .CreateController<T>(@in: game, bindTo: entity)
        .RegisterListeners(with: entity);

      GameObject LoadAndInstantiateObject(string with) =>
        Object.Instantiate(Resources.Load<GameObject>(with), Root(with), false);
    }

    public void BindExistingView<T>(GameContext game, IEntity entity, string name) where T : Component, IViewController
    {
      FindObjectInScene(with: name)
        .CreateController<T>(@in: game, bindTo: entity)
        .RegisterListeners(with: entity);

      GameObject FindObjectInScene(string with) => GameObject.Find(with).gameObject;
    }

    private Transform Root(string name) => name.StartsWith("UI") ? _uiRoot : _viewRoot;

    private void CacheUIRoot()
    {
      if (_uiRoot == null)
        _uiRoot = GameObject.Find(UIRootName).transform;
    }
  }

  public static partial class CleanCodeExtensions
  {
    public static GameObject CreateController<T>(this GameObject view, GameContext @in, IEntity @bindTo)
      where T : Component, IViewController
    {
      view
        .AddComponent<T>()
        .InitializeView(@in, @bindTo);

      return view;
    }

    public static GameObject AddListeners(this GameObject view, IEntity @from)
    {
      foreach (string component in @from.GetComponents().Select(c => c.GetType().Name))
      {
        Type type = Type.GetType($"Assets.Code.ViewListeners.{component.Replace("Component", "")}Listener");

        view.Do(v => v.AddComponent(type), when: type != null);
      }

      return view;
    }

    public static GameObject RegisterListeners(this GameObject view, IEntity with)
    {
      foreach (IEventListener listener in view.GetComponents<IEventListener>())
        listener.RegisterEventListeners(with);

      return view;
    }
  }
}