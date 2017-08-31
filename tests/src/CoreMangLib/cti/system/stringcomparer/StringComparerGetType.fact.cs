using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_stringcomparer_StringComparerGetType_StringComparerGetType_
    {
        [OuterLoop]
        [Fact]
        public void _system_stringcomparer_StringComparerGetType_StringComparerGetType_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\stringcomparer\\StringComparerGetType\\StringComparerGetType.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
