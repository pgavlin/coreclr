using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _nullabletypes_castclassvaluetype_d_castclassvaluetype_d_
    {
        [Fact]
        public void _nullabletypes_castclassvaluetype_d_castclassvaluetype_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\castclassvaluetype_d\\castclassvaluetype_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
