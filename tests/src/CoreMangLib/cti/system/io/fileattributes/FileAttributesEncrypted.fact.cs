using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_io_fileattributes_FileAttributesEncrypted_FileAttributesEncrypted_
    {
        [OuterLoop]
        [Fact]
        public void _system_io_fileattributes_FileAttributesEncrypted_FileAttributesEncrypted_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\io\\fileattributes\\FileAttributesEncrypted\\FileAttributesEncrypted.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
