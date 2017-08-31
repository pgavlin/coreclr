using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_stringcomparer_StringComparerEquals3_StringComparerEquals3_
    {
        [OuterLoop]
        [Fact]
        public void _system_stringcomparer_StringComparerEquals3_StringComparerEquals3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\stringcomparer\\StringComparerEquals3\\StringComparerEquals3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
