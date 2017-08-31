using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _nullabletypes_Desktop_boxunboxvaluetype_do_boxunboxvaluetype_do_
    {
        [Fact]
        public void _nullabletypes_Desktop_boxunboxvaluetype_do_boxunboxvaluetype_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\Desktop\\boxunboxvaluetype_do\\boxunboxvaluetype_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
