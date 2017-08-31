using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _nullabletypes_isinstvaluetype_ro_isinstvaluetype_ro_
    {
        [OuterLoop]
        [Fact]
        public void _nullabletypes_isinstvaluetype_ro_isinstvaluetype_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\isinstvaluetype_ro\\isinstvaluetype_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
