using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_stringcomparer_StringComparerEquals1_StringComparerEquals1_
    {
        [OuterLoop]
        [Fact]
        public void _system_stringcomparer_StringComparerEquals1_StringComparerEquals1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\stringcomparer\\StringComparerEquals1\\StringComparerEquals1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
