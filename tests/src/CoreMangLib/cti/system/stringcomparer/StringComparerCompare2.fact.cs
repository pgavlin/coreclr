using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_stringcomparer_StringComparerCompare2_StringComparerCompare2_
    {
        [OuterLoop]
        [Fact]
        public void _system_stringcomparer_StringComparerCompare2_StringComparerCompare2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\stringcomparer\\StringComparerCompare2\\StringComparerCompare2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
