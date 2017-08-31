using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _nullabletypes_boxunboxinterface_ro_boxunboxinterface_ro_
    {
        [Fact]
        public void _nullabletypes_boxunboxinterface_ro_boxunboxinterface_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\boxunboxinterface_ro\\boxunboxinterface_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
