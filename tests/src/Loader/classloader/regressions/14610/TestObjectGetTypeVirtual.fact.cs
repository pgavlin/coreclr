using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    public class _regressions_14610_TestObjectGetTypeVirtual_TestObjectGetTypeVirtual_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_14610_TestObjectGetTypeVirtual_TestObjectGetTypeVirtual_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Loader\\classloader\\regressions\\14610\\TestObjectGetTypeVirtual\\TestObjectGetTypeVirtual.cmd");
        }
    }
}
