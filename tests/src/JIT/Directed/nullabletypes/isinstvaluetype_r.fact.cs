using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _nullabletypes_isinstvaluetype_r_isinstvaluetype_r_
    {
        [OuterLoop]
        [Fact]
        public void _nullabletypes_isinstvaluetype_r_isinstvaluetype_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\isinstvaluetype_r\\isinstvaluetype_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
