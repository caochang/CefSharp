﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CefSharp
{
    /// <summary>
    /// Handler methods that get called AFTER the Popup is created.
    /// </summary>
    public interface IPopupHandler
    {
        /// <summary>
        /// Called before the passed popup window (browser) is closed.
        /// </summary>
        /// <param name="browserControl">The IWebBrowser control this popup is related to.</param>
        /// <param name="browser">The popup window instance that is closing.</param>
        void OnBeforeClose(IWebBrowser browserControl, IBrowser browser);

        /// <summary>
        /// Called after the paased popup window (browser) is created.
        /// </summary>
        /// <param name="browserControl">The IWebBrowser control this popup is related to.</param>
        /// <param name="browser">The popup window instance that was just created.</param>
        void OnAfterCreated(IWebBrowser browserControl, IBrowser browser);

        void OnFaviconUrlChange(IWebBrowser browserControl, IBrowser browser, List<string> iconUrls);

        void OnLoadingStateChange(IWebBrowser browserControl, IBrowser browser, bool isLoading, bool canGoBack, bool canGoForward);

        void OnStatusMessage(IWebBrowser browserControl, IBrowser browser, string message);
    }
}
