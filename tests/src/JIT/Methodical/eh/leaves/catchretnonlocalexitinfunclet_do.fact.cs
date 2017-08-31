using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_leaves_catchretnonlocalexitinfunclet_do_catchretnonlocalexitinfunclet_do_
    {
        [Fact]
        public void _eh_leaves_catchretnonlocalexitinfunclet_do_catchretnonlocalexitinfunclet_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\leaves\\catchretnonlocalexitinfunclet_do\\catchretnonlocalexitinfunclet_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
