using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_io_fileattributes_FileAttributesOffline_FileAttributesOffline_
    {
        [OuterLoop]
        [Fact]
        public void _system_io_fileattributes_FileAttributesOffline_FileAttributesOffline_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\io\\fileattributes\\FileAttributesOffline\\FileAttributesOffline.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
