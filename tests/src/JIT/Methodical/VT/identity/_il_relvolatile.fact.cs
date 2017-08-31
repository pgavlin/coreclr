using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_identity__il_relvolatile__il_relvolatile_
    {
        [OuterLoop]
        [Fact]
        public void _VT_identity__il_relvolatile__il_relvolatile_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\identity\\_il_relvolatile\\_il_relvolatile.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
