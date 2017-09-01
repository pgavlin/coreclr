using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    public class _nesting_coreclr_exec3_exec3_
    {
        [OuterLoop]
        [Fact]
        public void _nesting_coreclr_exec3_exec3_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Loader\\classloader\\nesting\\coreclr\\exec3\\exec3.cmd");
        }
    }
}
