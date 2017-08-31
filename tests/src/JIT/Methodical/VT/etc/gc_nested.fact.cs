using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_etc_gc_nested_gc_nested_
    {
        [OuterLoop]
        [Fact]
        public void _VT_etc_gc_nested_gc_nested_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\etc\\gc_nested\\gc_nested.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
