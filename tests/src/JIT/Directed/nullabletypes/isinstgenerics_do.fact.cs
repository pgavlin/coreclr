using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _nullabletypes_isinstgenerics_do_isinstgenerics_do_
    {
        [OuterLoop]
        [Fact]
        public void _nullabletypes_isinstgenerics_do_isinstgenerics_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\isinstgenerics_do\\isinstgenerics_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
