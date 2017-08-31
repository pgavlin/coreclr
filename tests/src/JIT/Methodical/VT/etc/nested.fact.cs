using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_etc_nested_nested_
    {
        [OuterLoop]
        [Fact]
        public void _VT_etc_nested_nested_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\etc\\nested\\nested.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
