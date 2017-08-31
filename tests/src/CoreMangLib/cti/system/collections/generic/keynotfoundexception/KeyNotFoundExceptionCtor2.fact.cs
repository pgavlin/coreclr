using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_keynotfoundexception_KeyNotFoundExceptionCtor2_KeyNotFoundExceptionCtor2_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_keynotfoundexception_KeyNotFoundExceptionCtor2_KeyNotFoundExceptionCtor2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\keynotfoundexception\\KeyNotFoundExceptionCtor2\\KeyNotFoundExceptionCtor2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
