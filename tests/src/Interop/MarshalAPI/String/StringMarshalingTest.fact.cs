using CoreclrTestLib;
using Xunit;

namespace Interop_MarshalAPI
{
    public class _String_StringMarshalingTest_StringMarshalingTest_
    {
        [OuterLoop]
        [Fact]
        public void _String_StringMarshalingTest_StringMarshalingTest_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Interop\\MarshalAPI\\String\\StringMarshalingTest\\StringMarshalingTest.cmd");
        }
    }
}
