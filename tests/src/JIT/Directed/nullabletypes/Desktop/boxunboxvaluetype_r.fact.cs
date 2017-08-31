using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _nullabletypes_Desktop_boxunboxvaluetype_r_boxunboxvaluetype_r_
    {
        [Fact]
        public void _nullabletypes_Desktop_boxunboxvaluetype_r_boxunboxvaluetype_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\Desktop\\boxunboxvaluetype_r\\boxunboxvaluetype_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
