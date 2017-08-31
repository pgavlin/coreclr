using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _nullabletypes_boxunboxenum_r_boxunboxenum_r_
    {
        [Fact]
        public void _nullabletypes_boxunboxenum_r_boxunboxenum_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\boxunboxenum_r\\boxunboxenum_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
