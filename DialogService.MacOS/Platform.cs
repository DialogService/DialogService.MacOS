using System;
using System.Collections.Generic;
using System.Text;

namespace DialogService.MacOS
{
    /// <summary>
    /// Functionality to get macOS platform implementation of dialog service
    /// </summary>
    public class PlatformImplementation : AbstractPlatform
    {
        public override IEnumerable<RuntimePlatform> Platform
			=> new RuntimePlatform[] { RuntimePlatform.MacOS };

        /// <summary>
        /// Gets MacOS dialog service implementation
        /// </summary>
        /// <returns></returns>
        public override IDialogService Get() => new MacOS.MacOSDialogService();
    }
}
