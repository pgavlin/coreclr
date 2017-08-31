using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _nullabletypes_isinstgenerics_ro_isinstgenerics_ro_
    {
        [OuterLoop]
        [Fact]
        public void _nullabletypes_isinstgenerics_ro_isinstgenerics_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\isinstgenerics_ro\\isinstgenerics_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
