using Code;
using Code.Services;
using Entitas;
using Entitas.CodeGeneration.Attributes;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

[Debug]
public sealed class DebugLog : IComponent { public string Value; } 

[Unique, Input]
public sealed class InputManger : IComponent { }

[Unique, Input]
public sealed class ButtonAInput : IComponent { }

[Unique, Input]
public sealed class LeftStickInput : IComponent { public Vector2 Value; }

[Unique, Input]
public sealed class InputServiceComponent : IComponent { public IInputService Value; }

[Meta, Unique]
public sealed class TimeServiceComponent : IComponent { public ITimeService Value; } 

[Meta, Unique]
public sealed class ViewServiceComponent : IComponent { public IViewService Value; }

[Meta, Unique]
public sealed class CoroutineDirectorComponent : IComponent { public ICoroutineDirectorService Value; }

[Game, Unique] 
public class Identifiers : IComponent, IService { public IIdentifierService Value; }

[Game]
public sealed class HeroComponent : IComponent { }

[Game]
public sealed class DeadComponent : IComponent { }

[Game]
public sealed class MovingComponent : IComponent { }

[Game]
public sealed class StoppedMovingComponent : IComponent { }

[Game]
public sealed class GlobalLightComponent : IComponent { }

[Game]
public sealed class CameraComponent : IComponent { }

[Game]
public sealed class TargetComponent : IComponent { public Transform Value; }

[Game]
public sealed class ViewComponent : IComponent { public IViewController Value; }

[Game]
public sealed class AssetComponent : IComponent { public string Value; }

[Game]
public sealed class RigidbodyComponent : IComponent { public Rigidbody2D Value; }

[Game]
public sealed class ImageComponent : IComponent { public Image Value; }

[Game]
public sealed class ColorComponent : IComponent { public Color Value; }

[Game]
public sealed class LightComponent : IComponent { public Light2D Value; }

[Game]
public sealed class TimeComponent : IComponent { public float Value; }

[Game]
public sealed class ColorStateComponent : IComponent { public int Value; }

[Game]
public class SpriteRendererComponent : IComponent { public SpriteRenderer Value; }

[Game]
public class ViewControllerComponent : IComponent { public IViewController Value; }

[Game]
public class Id : IComponent { [PrimaryEntityIndex] public int Value; }

[Game]
public class Duration : IComponent { public float Value; }

[Game]
public class DurationLeft : IComponent { public float Value; }

[Game]
public class DurationUp : IComponent { }

[Unique, Game]
public class CollidingViewRegister : IComponent, IService { public IRegisterService<IViewController> Value; }

[Game, Event(EventTarget.Self)]
public sealed class MovingSpeedComponent : IComponent { public float Value; }

[Game, Event(EventTarget.Self)]
public sealed class PositionComponent : IComponent { public Vector2 Value; }

[Game, Event(EventTarget.Self)]
public sealed class DestructedComponent : IComponent { }

[Game, Event(EventTarget.Self)]
public sealed class DirectionComponent : IComponent { public Vector2 Value; }