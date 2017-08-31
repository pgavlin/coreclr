using CoreclrTestLib;
using Xunit;

namespace Loader_multimodule
{
    class _DontUseNetmodule_DontUseNetmodule_
    {
        [OuterLoop]
        [Fact]
        public void _DontUseNetmodule_DontUseNetmodule_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\multimodule\\DontUseNetmodule\\DontUseNetmodule.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
