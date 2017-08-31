using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _MethodImpl_self_override2_self_override2_
    {
        [OuterLoop]
        [Fact]
        public void _MethodImpl_self_override2_self_override2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\MethodImpl\\self_override2\\self_override2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
