using CoreclrTestLib;
using Xunit;

namespace Interop_MarshalAPI
{
    public class _ReadWrite_ReadWriteIntPtr_ReadWriteIntPtr_
    {
        [Fact]
        public void _ReadWrite_ReadWriteIntPtr_ReadWriteIntPtr_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Interop\\MarshalAPI\\ReadWrite\\ReadWriteIntPtr\\ReadWriteIntPtr.cmd");
        }
    }
}
