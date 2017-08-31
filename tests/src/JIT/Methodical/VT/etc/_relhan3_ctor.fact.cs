using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_etc__relhan3_ctor__relhan3_ctor_
    {
        [OuterLoop]
        [Fact]
        public void _VT_etc__relhan3_ctor__relhan3_ctor_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\etc\\_relhan3_ctor\\_relhan3_ctor.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
