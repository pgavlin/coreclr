using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _int64_misc__il_relbox__il_relbox_
    {
        [OuterLoop]
        [Fact]
        public void _int64_misc__il_relbox__il_relbox_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\int64\\misc\\_il_relbox\\_il_relbox.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
