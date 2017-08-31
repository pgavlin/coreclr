using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _nullabletypes_isinstvaluetype_d_isinstvaluetype_d_
    {
        [OuterLoop]
        [Fact]
        public void _nullabletypes_isinstvaluetype_d_isinstvaluetype_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\isinstvaluetype_d\\isinstvaluetype_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
