using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_io_fileattributes_FileAttributesDeivce_FileAttributesDeivce_
    {
        [OuterLoop]
        [Fact]
        public void _system_io_fileattributes_FileAttributesDeivce_FileAttributesDeivce_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\io\\fileattributes\\FileAttributesDeivce\\FileAttributesDeivce.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
