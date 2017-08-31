using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_stringcompare_StringComparerCtor_StringComparerCtor_
    {
        [OuterLoop]
        [Fact]
        public void _system_stringcompare_StringComparerCtor_StringComparerCtor_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\stringcompare\\StringComparerCtor\\StringComparerCtor.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
