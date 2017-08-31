using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _nullabletypes_Desktop_boxunboxvaluetype_ro_boxunboxvaluetype_ro_
    {
        [Fact]
        public void _nullabletypes_Desktop_boxunboxvaluetype_ro_boxunboxvaluetype_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\Desktop\\boxunboxvaluetype_ro\\boxunboxvaluetype_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
