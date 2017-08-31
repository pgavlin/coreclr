using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _nullabletypes_isinstvaluetype_do_isinstvaluetype_do_
    {
        [Fact]
        public void _nullabletypes_isinstvaluetype_do_isinstvaluetype_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\isinstvaluetype_do\\isinstvaluetype_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
