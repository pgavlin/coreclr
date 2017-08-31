using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _nullabletypes_castclassvaluetype_ro_castclassvaluetype_ro_
    {
        [Fact]
        public void _nullabletypes_castclassvaluetype_ro_castclassvaluetype_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\castclassvaluetype_ro\\castclassvaluetype_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
