using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Code.Services
{
    public interface ICoroutineDirectorService
    {
        Coroutine Start(IEnumerator сoroutine);
    }
}