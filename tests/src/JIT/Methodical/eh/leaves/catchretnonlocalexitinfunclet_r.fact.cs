using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_leaves_catchretnonlocalexitinfunclet_r_catchretnonlocalexitinfunclet_r_
    {
        [Fact]
        public void _eh_leaves_catchretnonlocalexitinfunclet_r_catchretnonlocalexitinfunclet_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\leaves\\catchretnonlocalexitinfunclet_r\\catchretnonlocalexitinfunclet_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
