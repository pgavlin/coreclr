using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _MethodImpl_self_override5_self_override5_
    {
        [OuterLoop]
        [Fact]
        public void _MethodImpl_self_override5_self_override5_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\MethodImpl\\self_override5\\self_override5.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
