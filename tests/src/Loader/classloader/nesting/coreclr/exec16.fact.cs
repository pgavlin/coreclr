using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    public class _nesting_coreclr_exec16_exec16_
    {
        [OuterLoop]
        [Fact]
        public void _nesting_coreclr_exec16_exec16_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Loader\\classloader\\nesting\\coreclr\\exec16\\exec16.cmd");
        }
    }
}
