using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_notimplementedexception_NotImplementedExceptionCtor3_NotImplementedExceptionCtor3_
    {
        [OuterLoop]
        [Fact]
        public void _system_notimplementedexception_NotImplementedExceptionCtor3_NotImplementedExceptionCtor3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\notimplementedexception\\NotImplementedExceptionCtor3\\NotImplementedExceptionCtor3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
