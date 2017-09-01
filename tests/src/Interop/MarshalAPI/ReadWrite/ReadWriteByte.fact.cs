using CoreclrTestLib;
using Xunit;

namespace Interop_MarshalAPI
{
    public class _ReadWrite_ReadWriteByte_ReadWriteByte_
    {
        [Fact]
        public void _ReadWrite_ReadWriteByte_ReadWriteByte_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Interop\\MarshalAPI\\ReadWrite\\ReadWriteByte\\ReadWriteByte.cmd");
        }
    }
}
