using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _ldtoken__il_relldtokena__il_relldtokena_
    {
        [OuterLoop]
        [Fact]
        public void _ldtoken__il_relldtokena__il_relldtokena_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\ldtoken\\_il_relldtokena\\_il_relldtokena.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
