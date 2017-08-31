using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _nullabletypes_boxunboxenum_do_boxunboxenum_do_
    {
        [Fact]
        public void _nullabletypes_boxunboxenum_do_boxunboxenum_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\boxunboxenum_do\\boxunboxenum_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
