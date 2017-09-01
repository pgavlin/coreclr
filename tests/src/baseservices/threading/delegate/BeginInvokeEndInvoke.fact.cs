using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _delegate_BeginInvokeEndInvoke_BeginInvokeEndInvoke_
    {
        [OuterLoop]
        [Fact]
        public void _delegate_BeginInvokeEndInvoke_BeginInvokeEndInvoke_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\delegate\\BeginInvokeEndInvoke\\BeginInvokeEndInvoke.cmd");
        }
    }
}
