using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _nullabletypes_boxunboxinterface_d_boxunboxinterface_d_
    {
        [Fact]
        public void _nullabletypes_boxunboxinterface_d_boxunboxinterface_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\boxunboxinterface_d\\boxunboxinterface_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
