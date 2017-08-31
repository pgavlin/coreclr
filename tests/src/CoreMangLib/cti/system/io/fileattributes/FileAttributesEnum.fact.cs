using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_io_fileattributes_FileAttributesEnum_FileAttributesEnum_
    {
        [OuterLoop]
        [Fact]
        public void _system_io_fileattributes_FileAttributesEnum_FileAttributesEnum_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\io\\fileattributes\\FileAttributesEnum\\FileAttributesEnum.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
