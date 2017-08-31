using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _MethodImpl_override_override1_override_override1_
    {
        [OuterLoop]
        [Fact]
        public void _MethodImpl_override_override1_override_override1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\MethodImpl\\override_override1\\override_override1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
