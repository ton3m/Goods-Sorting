using System;

namespace _Project.Code.Services.AdShower
{
    public interface IAdShower
    {
        void ShowRewarded(Action onFinished = null, Action onFailed = null);
        void ShowBanner();
    }
}