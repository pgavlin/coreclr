using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_keynotfoundexception_KeyNotFoundExceptionCtor1_KeyNotFoundExceptionCtor1_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_keynotfoundexception_KeyNotFoundExceptionCtor1_KeyNotFoundExceptionCtor1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\keynotfoundexception\\KeyNotFoundExceptionCtor1\\KeyNotFoundExceptionCtor1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
