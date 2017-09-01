using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    public class _nesting_Regressions_dev10_602978_MainApp_MainApp_
    {
        [OuterLoop]
        [Fact]
        public void _nesting_Regressions_dev10_602978_MainApp_MainApp_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Loader\\classloader\\nesting\\Regressions\\dev10_602978\\MainApp\\MainApp.cmd");
        }
    }
}
