using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _MethodImpl_self_override1_self_override1_
    {
        [OuterLoop]
        [Fact]
        public void _MethodImpl_self_override1_self_override1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\MethodImpl\\self_override1\\self_override1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
