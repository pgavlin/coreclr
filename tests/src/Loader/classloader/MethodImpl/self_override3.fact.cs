using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _MethodImpl_self_override3_self_override3_
    {
        [OuterLoop]
        [Fact]
        public void _MethodImpl_self_override3_self_override3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\MethodImpl\\self_override3\\self_override3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
