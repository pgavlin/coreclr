using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _nullabletypes_boxunboxinterface_r_boxunboxinterface_r_
    {
        [Fact]
        public void _nullabletypes_boxunboxinterface_r_boxunboxinterface_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\boxunboxinterface_r\\boxunboxinterface_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
