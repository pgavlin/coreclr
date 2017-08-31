using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_io_fileattributes_FileAttributesNotContentIndexed_FileAttributesNotContentIndexed_
    {
        [OuterLoop]
        [Fact]
        public void _system_io_fileattributes_FileAttributesNotContentIndexed_FileAttributesNotContentIndexed_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\io\\fileattributes\\FileAttributesNotContentIndexed\\FileAttributesNotContentIndexed.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
