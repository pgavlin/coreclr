using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _delegate_BeginInvokeEndInvoke_BeginInvokeEndInvoke_
    {
        [OuterLoop]
        [Fact]
        public void _delegate_BeginInvokeEndInvoke_BeginInvokeEndInvoke_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\delegate\\BeginInvokeEndInvoke\\BeginInvokeEndInvoke.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
