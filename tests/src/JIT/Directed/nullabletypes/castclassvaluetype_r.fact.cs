using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _nullabletypes_castclassvaluetype_r_castclassvaluetype_r_
    {
        [Fact]
        public void _nullabletypes_castclassvaluetype_r_castclassvaluetype_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\castclassvaluetype_r\\castclassvaluetype_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
