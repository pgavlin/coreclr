using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_io_seekorigin_SeekOriginEnum_SeekOriginEnum_
    {
        [OuterLoop]
        [Fact]
        public void _system_io_seekorigin_SeekOriginEnum_SeekOriginEnum_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\io\\seekorigin\\SeekOriginEnum\\SeekOriginEnum.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
