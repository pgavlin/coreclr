using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _nullabletypes_castclassvaluetype_do_castclassvaluetype_do_
    {
        [Fact]
        public void _nullabletypes_castclassvaluetype_do_castclassvaluetype_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\castclassvaluetype_do\\castclassvaluetype_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
