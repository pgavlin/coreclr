using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_system
{
    class _delegate_VSD_OpenDelegate_OpenDelegate_
    {
        [OuterLoop]
        [Fact]
        public void _delegate_VSD_OpenDelegate_OpenDelegate_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\system\\delegate\\VSD\\OpenDelegate\\OpenDelegate.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
